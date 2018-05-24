<template>
  <v-container fluid>
    <v-btn color="success"
     @click="login"
     :loading="loading"
     :disabled="loading"
     >Send request</v-btn>
  </v-container>
</template>

<script>
import Api from '../services/api'
export default {
  data () {
    return {
      loading: false
    }
  },
  methods: {
    login: async function (event) {
      this.loading = true
      await Api.login('asd', 'zxc')
      this.loading = false
    }
  },
  name: 'App'
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.custom-loader {
  animation: loader 1s infinite;
  display: flex;
}
@-moz-keyframes loader {
  from {
    transform: rotate(0);
  }
  to {
    transform: rotate(360deg);
  }
}
@-webkit-keyframes loader {
  from {
    transform: rotate(0);
  }
  to {
    transform: rotate(360deg);
  }
}
@-o-keyframes loader {
  from {
    transform: rotate(0);
  }
  to {
    transform: rotate(360deg);
  }
}
@keyframes loader {
  from {
    transform: rotate(0);
  }
  to {
    transform: rotate(360deg);
  }
}
</style>
