#!/bin/bash
echo '-----------------------------------------------------------------------------------------------------------------'
#lista de todas as contas de usuários regulares que contem o texto /home no arquivo /etc/passwd
grep   /home /etc/passwd

echo '-------------------------------------localiza as variáveis de ambiente que contem HO no começo----------------------------------------------------------------------------'
#localiza todas as variáveis de ambiente que começam com HO
env | grep ^HO

echo '-------------------------------------Remova seções com o cut----------------------------------------------------------------------------'
#exibe o sexto campo (-f6) e delimita com o caractere (-d':') 
grep /home /etc/passwd |cut -d':' -f6 -

echo '-------------------------------------traduza ou exclua caractes com (tr)----------------------------------------------------------------------------'
#
read -p 'Digite seu nome em upper case: ' NOME
echo $NOME | tr [A-Z] [a-z]


echo '-------------------------------------Editor de fluxo (sed)----------------------------------------------------------------------------'
#fucniona quase igual o (greep), a diferença é que o sed é um editor de script simples 
sed -n '/home/p' '/etc/passwd'
