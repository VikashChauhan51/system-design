import { defineConfig } from 'vitepress'

// https://vitepress.dev/reference/site-config
export default defineConfig({
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
        text: 'Algorithms',
        items: [
          { text: 'Reverse String', link: '/algorithms/reverse-string' },
          { text: 'Reverse String II', link: '/algorithms/reverse-string-ii' },
          { text: 'Reverse String III', link: '/algorithms/reverse-string-iii' }
        ]
      }
    ],

    socialLinks: [
      { icon: 'github', link: 'https://github.com/vuejs/vitepress' }
    ]
  }
})
