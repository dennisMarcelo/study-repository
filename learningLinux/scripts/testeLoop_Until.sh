#!/bin/bash
N=0
T='#'
until [ $N -eq 200 ]; do
	echo $N $T
	T=$T'#';
	let N=$N+1;
done
