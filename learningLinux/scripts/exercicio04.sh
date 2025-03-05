#!/bin/bash
#O exercicio mandava eu ser agressivo com quem gosta de windows e mac
#Fiz o melhor que pude
#Respeito as pessoas que usam outros tipos de sistema OP
#Mesmo sabendo que elas são burras.
echo "What is your favorite  operating system, Mac, Windows or Linux "
read -p "Digite em minusculo: " OS
case $OS in 
	"windows")
		echo "Não acredito que você tem coragem de pagar tão caro por uma licença. Por acaso você pensa"
	;;
	"mac")
		echo "Ta de brincadeira, Sério, MAC? Esperava mais de você, playboyzinho"
	;;
	"linux")
		echo "Ótima escolha!"
	;;
	*)
		echo "Isso é um sistema operacional"
	;;
esac
