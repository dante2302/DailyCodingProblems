#!/bin/bash

EXPECTED_URL="https://github.com/yourusername/yourrepository.git"

if ! git rev-parse --is-inside-work-tree &>/dev/null; then
    echo "Error: This script must be run inside a Git repository."
    exit 1
fi

CURRENT_URL=$(git config --get remote.origin.url)

if [ "$CURRENT_URL" != "$EXPECTED_URL" ]; then
    echo "Error: This script can only be run in the repository at '$EXPECTED_URL'."
    exit 1
fi

read -p "Heading: " HEADING
read -p "Description: " DESCRIPTION
read -p "Difficulty: " DIFFICULTY

P="P"
NUMBER=1

# Checks the current sequence number in a directory full of directories as such: /P1, /P2 ....
# And Assigns the next corresponding number
while [[ -d "${P}${NUMBER}" ]]; do
    NUMBER=$((NUMBER + 1))
done

cd ../

mkdir "${P}${NUMBER}"
