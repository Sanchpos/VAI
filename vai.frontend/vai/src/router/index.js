import Vue from 'vue'
import Router from 'vue-router'
// import HelloWorld from '@/components/HelloWorld'
import Research from '@/components/Research'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'HelloWorld',
      component: Research
    },
    {
      path: 'research',
      name: 'research',
      component: Research
    }
  ]
})
