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
          { text: 'Remove Duplicates II', link: '/algorithms/string/remove-duplicates-ii' }
        ]
      },
      {

        text: 'Number Algorithms',
        items: [
          { text: 'Factorial', link: '/algorithms/number/factorial' },
          { text: 'Fibonacci', link: '/algorithms/number/fibonacci' },
          { text: 'Reverse', link: '/algorithms/number/reverse' },
          { text: 'Sum Digits', link: '/algorithms/number/sum-digits' },
          { text: 'Divide Number', link: '/algorithms/number/divide-number' },
        ]
      }
    ],

    socialLinks: [
      { icon: 'github', link: 'https://github.com/vuejs/vitepress' }
    ]
  }
})
