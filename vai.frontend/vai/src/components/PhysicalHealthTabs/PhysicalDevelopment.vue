<template>
  <v-container fluid>
    <v-layout row>
      <v-flex xs2>
        <v-layout column>
          <h3>Соматоскопия</h3>
          <v-select :items="bodyTypes" label="Тип телосложения"></v-select>
          <v-select :items="spineTypes" label="Осанка"></v-select>
          <h3>Антропометрия</h3>
          <v-text-field label="Рост" suffix="см"></v-text-field>
          <v-text-field label="Масса тела" suffix="кг"></v-text-field>
          <v-text-field label="Жизненная емкость легких" suffix="мл"></v-text-field>
          <h3>Динамометрия</h3>
          <v-text-field label="Левая рука" suffix="кг"></v-text-field>
          <v-text-field label="Правая рука" suffix="кг"></v-text-field>
          <v-text-field label="Становая" suffix="кг"></v-text-field>
        </v-layout>
      </v-flex>
    </v-layout>
  </v-container>
</template>

<script>
export default {
  data () {
    return {
      bodyTypes: ['Нормостеник', 'Астеник', 'Гиперстеник'],
      spineTypes: ['Нормальная', 'Плоская', 'Сутулая', 'Лордическая']
    }
  },
  methods: {},
  tabText: 'Физическое развитие',
  name: 'PhysicalDevelopment'
}
</script>