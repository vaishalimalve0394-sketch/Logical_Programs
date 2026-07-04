# Logical_Programs
Anagram Logical Program
Problem Statement
Given a sentence, find all pairs of words that are anagrams of each other (i.e., words made of the same letters, rearranged, ignoring case).
Example:
Input: "I will listen music in silent at night because stressed due to such thing eating desserts"
Output: [["listen", "silent"], ["night", "thing"], ["stressed", "desserts"]]

Approach 1: Brute Force (Nested Loop)
Idea: Compare every word with every other word that comes after it, check if they are anagrams by sorting their characters and comparing.
Steps:

Split the sentence into words.
Use two nested loops — outer loop picks a word, inner loop compares it with all following words.
For each pair, sort the characters of both words and check if the sorted strings are equal.
If equal, it's an anagram pair — store or print it.

Complexity:

Time: O(n² × k log k) — n = number of words, k = average word length (due to sorting inside the comparison).
Space: O(k) for temporary char arrays.

When to use: Simple to understand, fine for small inputs, but inefficient for large sentences since every word is compared against every other word.

Approach 2: Dictionary / HashMap (Grouping by Signature)
Idea: Instead of comparing every pair, compute a "signature" for each word (its letters sorted alphabetically). Words with the same signature are anagrams of each other. Group words by signature using a Dictionary<string, List<string>>.
Steps:

Split the sentence into words.
For each word, generate its signature by lowercasing and sorting its characters.
Use the signature as a dictionary key; append the word to the list of values for that key.
After processing all words, any group (dictionary value) with more than one word contains anagrams.
Generate all pairs within each group and print/store them.

Complexity:

Time: O(n × k log k) — one pass through words, sorting each word once (no pairwise comparisons).
Space: O(n × k) for storing the dictionary.

When to use: Much more efficient for larger inputs since it avoids the O(n²) comparisons of the brute-force approach. This is the standard "Group Anagrams" hashmap pattern used across languages (Python, Java, C#, etc.).

Approach 3: LINQ (C# specific)
Idea: Same signature-grouping idea as the Dictionary approach, but expressed declaratively using LINQ's GroupBy.
Steps:

Split the sentence into words.
Use GroupBy with the sorted-letter signature as the key selector.
Filter groups where Count() > 1 (i.e., actual anagram groups).
Use SelectMany to generate all pairs within each group.

Complexity: Same as the Dictionary approach — O(n × k log k) — since GroupBy internally uses a hash-based grouping mechanism.
When to use: More concise and idiomatic in C#, good when you want a functional/query-style solution rather than manual loops.

Comparison Table
ApproachTime ComplexitySpace ComplexityReadabilityEfficiencyBrute ForceO(n² × k log k)O(k)High (beginner-friendly)LowDictionary/MapO(n × k log k)O(n × k)MediumHighLINQO(n × k log k)O(n × k)High (concise)High

Key Takeaway

Brute force is easiest to understand but doesn't scale well.
Dictionary/HashMap and LINQ approaches are functionally equivalent under the hood — both use hashing to group words by their letter-signature — but LINQ offers more concise, declarative syntax while the Dictionary approach gives more manual control (useful if you're learning the underlying mechanics).
