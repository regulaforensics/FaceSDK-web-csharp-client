#!/bin/sh

cd ../..
apt install -y git
git config --global url."https://$GITHUB_TOKEN@github.com/".insteadOf "git@github.com:"

git clone git clone https://github.com/regulaforensics/FaceSDK-web-openapi.git

apt update
apt install -y apt-transport-https ca-certificates curl software-properties-common
curl -fsSL https://download.docker.com/linux/ubuntu/gpg | sudo apt-key add -
add-apt-repository "deb [arch=amd64] https://download.docker.com/linux/ubuntu focal stable"
apt install -y docker-ce


cd FaceSDK-web-csharp-client

./update-models.sh
