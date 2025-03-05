#!/bin/bash
N=0
T='.'
while [ $N -lt 200 ]; do
	echo $T;
	T=$T'.';
	let N=$N+1;
done
