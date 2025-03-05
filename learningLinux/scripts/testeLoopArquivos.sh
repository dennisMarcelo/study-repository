#!/bin/bash
#(@)Criar arquivos com Loop
for ((a=1; a<=5000; a++)) ; do 
	touch ~/Documentos/pasta_de_testes/"arquivo$a"
done
