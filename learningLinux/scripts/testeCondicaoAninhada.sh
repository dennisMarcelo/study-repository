#!/bin/bash
read -p 'digite um numero: ' num
if [ $num -le 5 ] ; then
	echo $num' <= 5'
elif [ $num -ge 10 ] ; then	
	echo $num' >= 10'
else
	echo '5 <' $num '< 10'
fi	
