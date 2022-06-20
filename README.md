# non-divisible-subset

Given a set of distinct integers, print the size of a maximal subset of S where the sum of any 2 numbers in S' is 
not evenly divisible by k.
Example
S = [19, 10, 12, 10, 24, 25, 22] k = 4
One of the arrays that can be created is S1[0] = [10, 12, 25]. Another is S' [1] = [19, 22, 24]. After testing all 
permutations, the maximum length solution array has 3 elements.


Function Description
Complete the nonDivisibleSubset function in the editor below.
nonDivisibleSubset has the following parameter(s):
• int WI]: an array of integers
• int k: the divisor


Returns
• int: the length of the longest subset of S meeting the criteria
