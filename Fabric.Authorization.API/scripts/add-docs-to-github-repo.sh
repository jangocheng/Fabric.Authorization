﻿#!/bin/bash

echo "Cloning Git Wiki repo..."
git clone https://$GITWIKIACCESSTOKEN@github.com/HealthCatalyst/Fabric.Authorization.wiki.git

echo "Moving MD files to Fabric.Authorization.wiki..."
mv overview.md API-Reference-Overview.md
mv paths.md API-Reference-Resources.md
mv definitions.md API-Reference-Models.md
mv security.md API-Reference-Security.md

mv *.md Fabric.Authorization.wiki

echo "Changing directory..."
cd Fabric.Authorization.wiki

echo "-----Present directory = $(pwd)-----"

git config user.name "vsts build"
git config user.email "djjoebanks@gmail.com"
git add *.md
git commit -m 'update API documentation'
git push origin master

