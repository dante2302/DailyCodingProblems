NUMBER=1
while true; do
    NEW_FILE="P$NUMBER"
    echo $NUMBER
    if [[ ! -f "$NEW_FILE.cs" ]]; then
        break
    fi
    ((NUMBER++))
done

cat <<EOL > "$NEW_FILE.cs"
using Problems.$NEW_FILE;
namespace Tests;

public class $NEW_FILE
{
    private readonly Solution _solution = new();

    [Fact]
    public void Basic()
    {
    }
}
EOL
