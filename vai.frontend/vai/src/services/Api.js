import Axios from 'axios'

class Api {
  constructor () {
    this.instance = Axios.create({
      baseURL: 'https://localhost:45454'
    })
  }

  async login (login, pass) {
    try {
      let response = await this.instance.post('/login', {username: login, password: pass})
      this.instance.defaults.headers.common['Authorization'] = response.data.token
    } catch (error) {
      console.error(error.message)
    }
  }
}

var api = new Api()
export default api
