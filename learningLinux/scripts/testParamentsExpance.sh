#!/bin/bash
MYFILENAME="/home/digby/myfile.txt"
FILE=${MYFILENAME##*/}  #FILE torna-se "myfile.txt"
DIR=${MYFILENAME%/*}    #DIR torna-se "/home/digby"
NAME=${FILE%.*}         #NAME torna-se "myfile"
EXTENSION=${FILE##*.}  #EXTENCION torna-se "txt"
echo $FILE
echo $DIR
echo $NAME
echo $EXTENSION
