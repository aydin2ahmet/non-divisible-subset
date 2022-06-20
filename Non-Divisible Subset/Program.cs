var result = nonDivisibleSubset(3, new List<int>() { 1, 7, 2, 4 });

Console.WriteLine(result);

int nonDivisibleSubset(int k, List<int> s)
{
    Dictionary<int, int> valueDict = new Dictionary<int, int>();

    foreach (var i in s)
    {
        var mod = i % k;

        if (valueDict.ContainsKey(mod))
            valueDict[mod] += 1;
        else
            valueDict[mod] = 1;
    }

    var loopCount = Math.Ceiling((decimal)k / 2);
    var totalCount = 0;

    for (int i = 1; i < loopCount; i++)
    {
        int firstValue = 0;
        int secondValue = 0;

        if (valueDict.ContainsKey(i))
            firstValue = valueDict[i];

        if (valueDict.ContainsKey(k - i))
            secondValue = valueDict[k - i];

        totalCount += firstValue > secondValue ? firstValue : secondValue;
    }

    if (valueDict.ContainsKey(0))
        totalCount += 1;

    if (k % 2 == 0 && valueDict.ContainsKey(k / 2))
        totalCount += 1;

    return totalCount;
}
