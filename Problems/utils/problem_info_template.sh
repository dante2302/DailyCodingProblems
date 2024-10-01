#!/bin/bash

# Define the expected repository URL (adjust this to your needs)
EXPECTED_URL="https://github.com/yourusername/yourrepository.git"

# Check if the script is being run in a Git repository
if ! git rev-parse --is-inside-work-tree &>/dev/null; then
    echo "Error: This script must be run inside a Git repository."
    exit 1
fi

# Get the current repository URL
CURRENT_URL=$(git config --get remote.origin.url)

# Check if the current repository matches the expected URL
if [ "$CURRENT_URL" != "$EXPECTED_URL" ]; then
    echo "Error: This script can only be run in the repository at '$EXPECTED_URL'."
    exit 1
fi

# Check if the correct number of parameters are provided
if [ "$#" -ne 3 ]; then
    echo "Usage: $0 <Heading> <Description> <Difficulty>"
    exit 1
fi