#!/bin/bash
ONE=$1
TWO=$2
THREE=$3
ONE=${ONE:-"NULL"}
TWO=${TWO:-"NULL"}
THREE=${THREE:-"NULL"}


echo "There are $# parameters that include $@"
echo "The first is $ONE, the second $TWO, the third is $THREE"
