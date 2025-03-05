#!/bin/bash
#(@)ph
#A very simple phone
#Type "ph new name" to add to the list, or
#Simple type "ph name" to obtain a telephone number

PHONELIST=~/Documentos/learningLinux/scripts/testePhones/.phonelist.txt

#If there is no comande line parameter ($#), there is 
#a problem, so ask about what they are talking.

if [ $# -lt 1 ] ; then 
	echo "what phone number do you want? "
	exit 1
fi

#Do you want to add a new phone number?
if [ $1 = "new" ] ; then 
	shift
	echo $* >> $PHONELIST
	echo $* added to database
	exit 0
fi

#No. but does the file still have something in it ?
#This  may be the firt time that we use it, after all.

if [ ! -s $PHONELIST ] ; then 
	echo "No number in the phone book yet"
	exit 1
else
	grep -i -q "$*" $PHONELIST		#search the file silently
	if [ $? -ne 0 ] ; then 			#did we find somenthing
		echo "Sorry,  but that name was not found in the list. "
		exit 1
	else 
		grep -i "$*" $PHONELIST
	fi
fi
exit 0
