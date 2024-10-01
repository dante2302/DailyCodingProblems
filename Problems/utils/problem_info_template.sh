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

valid_difficulty=false
# Loop until valid input is received
while [ "$valid_difficulty" = false ]; do
    read -p "Enter a valid Difficulty: (Easy, Medium, Hard)" DIFFICULTY

    if [[ "$DIFFICULTY" == "Easy" || "$DIFFICULTY" == "Medium" || "$DIFFICULTY" == "Hard"]]; then
        valid_difficulty=true  
    else
        echo "Invalid input. Please enter one of the following: Easy Medium Hard."
    fi
done

P="P"
NUMBER=1

# Checks the current sequence number in a directory full of directories as such: /P1, /P2 ....
# And Assigns the next corresponding number
while [[ -d "${P}${NUMBER}" ]]; do
    NUMBER=$((NUMBER + 1))
done

cd ../

NEW_DIR="${P}${NUMBER}"

mkdir NEW_DIR
cd NEW_DIR


cat <<EOL > "Info.cs"
using Problems.utils;
namespace Problems.P${NUMBER};

public class Info : IProblemDescriptor
{
    public string Heading => "${HEADING}";
    public string Description => @"${DESCRIPTION}";

    public ProblemDifficulty Difficulty => ProblemDifficulty.${DIFFICULTY} 
}
EOL

cat <<EOL > "Solution.cs"
using Problems.utils;

namespace Problems.P${NUMBER};

public class Solution : ISolution
{
    public int Method(int[] numbers)
    {
    }

    public SolutionInfo Info { get; set;} = new()
    {
        Approach = @"";
        TimeComplexity = "",
        SpaceComplexity = "",
        TimeSpent = ""
    };
}
EOL