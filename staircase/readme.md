# Staircase Problem
## Problem
Input ‘N’ as the height of the Staircase , Draw a staircase with the given height.
## Analysis
- Total no. of lines in output is equal to height of the staircase.
- No. of hashes ‘#’ in last line is equal to the height of staircase.
- In output,line 1 has 1 hash,line 2 has 2 hashes and so on… so to print this pattern we have to print blank space ” “ before hashes which will be equal to the value obtained by subtracting the line number or number of hashes from the height of the staircase.
## Solution
### Method 1: (nested for loops, Time Complexity: O(N<sup>2</sup>))

Algorithm:
- Get the number of total rows or maximum number of #s that we need to print from s standard input.
- Loop over total number of rows because we need to print white spaces and # in each line.

### Method 2: (Optimized, Time Complexity: O(N))
Algorithm:

String constructor, 1st argument is character that you wanna show, 2nd argument is number of time you want to replicate it.
