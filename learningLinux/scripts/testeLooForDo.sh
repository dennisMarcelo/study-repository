#!/bin/bash
for NUMBER in 0 1 2 3 4 5 6 7 8 9 10 11 12
do
	echo loop: $NUMBER
done

echo ---------------------------

for FILE in '/bin/ls'
do
	echo $FILE
done

echo ---------------------------

for NAME in Dennis marcelo dos Santos ; do
	echo $NAME é genial! kkk
done

echo ---------------------------
echo o bash permite usar a sintaxe C para controlar seus loops

LIMITE=20
for ((a=1; a<=LIMITE; a++)) ; do
	echo "$a"
done
