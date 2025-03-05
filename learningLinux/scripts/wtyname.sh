#!/bin/bash
clear
number=22
echo "What your name?"
read -p ": " name

clear
name=${name:-"null"}
if [ $name != "null" ]; then
	echo "Hi, $name you are come!"
else
	echo "Ok, no have probrem, You don't need to speak your name. We undertand!"
fi
echo "firt increment $((++number))"
echo "second increment $((number++))"
echo "thid increment $((++number))"
