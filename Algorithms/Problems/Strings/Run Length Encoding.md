````markdown

## Run Length Encoding

**Description:** Run-Length Encoding (RLE) is a simple lossless compression technique that replaces consecutive repeated characters (runs) with a single instance of the character followed by the count. This document covers encoding and decoding of strings using RLE and common considerations.

**Examples:**
```
Encode Input: "AAAABBBCCDAA"
Encode Output: "A4B3C2D1A2"

Decode Input: "A4B3C2D1A2"
Decode Output: "AAAABBBCCDAA"

Edge Example (single chars):
Encode Input: "ABCD"
Encode Output: "A1B1C1D1" (optionally you may omit counts of 1 depending on the variant)
```

#### Constraints
- Input is an arbitrary string of characters.
- Counts may become multi-digit for long runs; encoding should represent counts as their decimal string.

### Approach

Two common operations:
- Encode: scan the string and collapse consecutive identical characters into (char + count).
- Decode: parse alternating character and count tokens and expand runs.

We give straightforward pseudocode for both operations and note an optimization to omit `1` counts in a compact variant.

### Pseudocode — Encode

```
FUNCTION RLE_Encode(s):
    IF s IS NULL OR LENGTH(s) == 0: RETURN ""

    builder = NEW STRING_BUILDER()
    current = s[0]
    count = 1

    FOR i FROM 1 TO LENGTH(s)-1:
        IF s[i] == current:
            count = count + 1
        ELSE:
            builder.APPEND(current)
            builder.APPEND(TO_STRING(count))
            current = s[i]
            count = 1
        END IF
    END FOR

    // append last run
    builder.APPEND(current)
    builder.APPEND(TO_STRING(count))
    RETURN builder.TO_STRING()
END FUNCTION
```

### Pseudocode — Decode

```
FUNCTION RLE_Decode(encoded):
    IF encoded IS NULL OR LENGTH(encoded) == 0: RETURN ""

    builder = NEW STRING_BUILDER()
    i = 0
    WHILE i < LENGTH(encoded):
        // read character
        ch = encoded[i]
        i = i + 1

        // read decimal count (one or more digits)
        countStr = ""
        WHILE i < LENGTH(encoded) AND encoded[i] IS DIGIT:
            countStr = countStr + encoded[i]
            i = i + 1
        END WHILE

        count = PARSE_INT(countStr)
        // append ch count times
        FOR k FROM 1 TO count:
            builder.APPEND(ch)
        END FOR
    END WHILE

    RETURN builder.TO_STRING()
END FUNCTION
```

```csharp
// Simple C# encode/decode implementations
public static string RLEEncode(string s)
{
    if (string.IsNullOrEmpty(s)) return string.Empty;
    var sb = new StringBuilder();
    char cur = s[0];
    int cnt = 1;
    for (int i = 1; i < s.Length; i++)
    {
        if (s[i] == cur) cnt++;
        else
        {
            sb.Append(cur);
            sb.Append(cnt);
            cur = s[i];
            cnt = 1;
        }
    }
    sb.Append(cur);
    sb.Append(cnt);
    return sb.ToString();
}

public static string RLEDecode(string encoded)
{
    if (string.IsNullOrEmpty(encoded)) return string.Empty;
    var sb = new StringBuilder();
    int i = 0;
    while (i < encoded.Length)
    {
        char ch = encoded[i++];
        if (i >= encoded.Length) throw new FormatException("Missing count for character");
        var numSb = new StringBuilder();
        while (i < encoded.Length && char.IsDigit(encoded[i])) numSb.Append(encoded[i++]);
        int count = int.Parse(numSb.ToString());
        for (int k = 0; k < count; k++) sb.Append(ch);
    }
    return sb.ToString();
}
```

### Visualization (step-by-step)

Encode `s = "AAAABBBCCDAA"`:
- Start: cur='A', cnt=1
- i=1..3: A matches → cnt increments to 4
- i=4: char 'B' differs → append "A4"; cur='B', cnt=1
- i=5..6: B matches → cnt increments to 3
- next: append "B3"; cur='C', cnt=1 → then "C2" → "D1" → "A2"
- Final encoded: "A4B3C2D1A2"

Decode `encoded = "A4B3C2D1A2"`:
- Read 'A', read digits "4" → append 'A' 4 times
- Read 'B', read "3" → append 'B' 3 times
- Continue similarly → reconstructed string

### Variants and Considerations
- Compact variant: omit `1` counts (encode `ABCD` -> `ABCD` or `A4B3C2DA2` depending on rules). This affects decode logic (must detect when count is missing).
- Binary-safe RLE: if input can include digits or the count delimiter, use separators or fixed-width counts.
- Streaming: can encode/decode in a streaming fashion without storing entire input/output in memory.

### Edge Cases
- Empty input -> returns empty
- Encoded string malformed (missing count, non-digit count) -> decoder should raise/return error
- Very long runs -> counts become multi-digit; decoding should parse multi-digit counts correctly

### Complexity
- **Time Complexity (Encode):** `O(n)` — single pass over input string.
- **Time Complexity (Decode):** `O(m + r)` where `m` is length of encoded string and `r` is total length of reconstructed output (decoder must write each character of output), effectively `O(output_length)`.
- **Space Complexity:** `O(n)` for encode (output size may be up to input size or smaller); decode requires `O(output_length)` to store reconstructed string unless streaming.

````
