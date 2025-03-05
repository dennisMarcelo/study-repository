#!/bin/bash
echo "A1 A2 A3 A4 A5"
read -p "digite o numero da poltron que deseja sentar: " CADEIRA
case $CADEIRA in
	"A1")
		echo "Confirmação da cadeira A1.";;
	"A2")
		echo "Confirmação da cadeira A2.";;
	"A3")
		echo "Confirmação da cadeira A3.";;
	"A4")
		echo "Confirmação da cadeira A4.";;
	"A5")
		echo "Confirmação da cadeira A5.";;
	*)
		echo "Esta cadeira não é valida.";;
esac
