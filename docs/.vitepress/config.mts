import { defineConfig } from 'vitepress'

// https://vitepress.dev/reference/site-config
export default defineConfig({
  base:"/system-design/",
  title: "System Design",
  description: "System Design",
  themeConfig: {
    // https://vitepress.dev/reference/default-theme-config
    nav: [
      { text: 'Home', link: '/' },
      { text: 'Algorithms', link: '/algorithms' }
    ],

    sidebar: [
      {

        text: 'String Algorithms',
        items: [
          { text: 'Reverse String', link: '/algorithms/string/reverse-string' },
          { text: 'Reverse String II', link: '/algorithms/string/reverse-string-ii' },
          { text: 'Reverse String III', link: '/algorithms/string/reverse-string-iii' },
          { text: 'Anagram', link: '/algorithms/string/anagram' },
          { text: 'Palindrome', link: '/algorithms/string/palindrome' },
          { text: 'Palindrome II', link: '/algorithms/string/palindrome-ii' },
          { text: 'Remove Duplicates', link: '/algorithms/string/remove-duplicates' },
          { text: 'Multiply Strings', link: '/algorithms/string/multiply-strings' },
          { text: 'String Compress', link: '/algorithms/string/string-compress' },
          { text: 'Merge Strings Alternately', link: '/algorithms/string/merge-strings-alternately' }

        ]
      },
      {

        text: 'Number Algorithms',
        items: [
          { text: 'Reverse', link: '/algorithms/number/reverse' },
          { text: 'Sum Digits', link: '/algorithms/number/sum-digits' },
          { text: 'Integer to Roman', link: '/algorithms/number/integer-to-roman' },
        ]
      },
      {
        text: 'Array Algorithms',
        items: [
          { text: 'Two Sum', link: '/algorithms/array/two-sum' },
          { text: 'Two Sum II', link: '/algorithms/array/two-sum-ii' },
          { text: 'Move Zeroes', link: '/algorithms/array/move-zeroes' },
          { text: 'Trapping Rain Water', link: '/algorithms/array/trapping-rain-water' },
        ]
      },
      {
        text: 'Stack Algorithms',
        items: [
          { text: 'Valid Parentheses', link: '/algorithms/stack/valid-parentheses' },
          { text: 'Remove Duplicates II', link: '/algorithms/stack/remove-duplicates-ii' },
        ]
      },
      {

        text: 'Rcursion Algorithms',
        items: [
          { text: 'Factorial', link: '/algorithms/recursion/factorial' },
          { text: 'Fibonacci', link: '/algorithms/recursion/fibonacci' },
          { text: 'Divide Number', link: '/algorithms/recursion/divide-number' },
          { text: 'Integer to English Words', link: '/algorithms/recursion/integer-to-english-words' },
        ]
      },
    ],

    socialLinks: [
      { icon: 'github', link: 'https://github.com/vuejs/vitepress' }
    ]
  }
})
