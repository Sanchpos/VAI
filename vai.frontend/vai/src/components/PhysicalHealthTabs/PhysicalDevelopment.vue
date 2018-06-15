<template>
  <v-container>
    <v-form v-model="formValid">
      <v-layout row wrap>
        <v-flex xs4 class="px-2">
          <v-layout column >
            <h3>Соматоскопия</h3>
            <v-select :items="bodyTypes" label="Тип телосложения"></v-select>
            <v-select :items="spineTypes" label="Осанка"></v-select>
            <h3>Антропометрия</h3>
            <v-text-field label="Рост" suffix="см" :rules="doubleFieldValidationRules"></v-text-field>
            <v-text-field label="Масса тела" suffix="кг" :rules="doubleFieldValidationRules"></v-text-field>
            <v-text-field label="Жизненная емкость легких" suffix="мл" :rules="doubleFieldValidationRules"></v-text-field>
            <h3>Динамометрия</h3>
            <v-text-field label="Левая рука" suffix="кг" :rules="doubleFieldValidationRules"></v-text-field>
            <v-text-field label="Правая рука" suffix="кг" :rules="doubleFieldValidationRules"></v-text-field>
            <v-text-field label="Становая" suffix="кг" :rules="doubleFieldValidationRules"></v-text-field>
          </v-layout>
        </v-flex>
        <v-flex xs4 class="px-2">
          <v-layout column wrap>
            <h3>Окружность</h3>
            <v-text-field label="Голова" suffix="см" :rules="doubleFieldValidationRules"></v-text-field>
            <v-text-field label="Шея" suffix="см" :rules="doubleFieldValidationRules"></v-text-field>
            <v-text-field label="Плечо" suffix="см" :rules="doubleFieldValidationRules"></v-text-field>
            <v-text-field label="Грудная клетка" suffix="см" :rules="doubleFieldValidationRules"></v-text-field>
            <v-text-field label="Талия" suffix="см" :rules="doubleFieldValidationRules"></v-text-field>
            <v-text-field label="Бедро" suffix="см" :rules="doubleFieldValidationRules"></v-text-field>
            <v-text-field label="Голень" suffix="см" :rules="doubleFieldValidationRules"></v-text-field>
            <v-text-field label="Длинна ладони" suffix="см" :rules="doubleFieldValidationRules"></v-text-field>
          </v-layout>
        </v-flex>
        <v-flex xs4 class="px-2">
          <v-layout column wrap>
            <h3>Толщина жировой складки</h3>
            <v-text-field label="Бицепс" suffix="мм" :rules="doubleFieldValidationRules"></v-text-field>
            <v-text-field label="Трицепс" suffix="мм" :rules="doubleFieldValidationRules"></v-text-field>
            <v-text-field label="Лопатка" suffix="мм" :rules="doubleFieldValidationRules"></v-text-field>
            <v-text-field label="6 ребро" suffix="мм" :rules="doubleFieldValidationRules"></v-text-field>
            <v-text-field label="Живот" suffix="мм" :rules="doubleFieldValidationRules"></v-text-field>
            <v-text-field label="Бедро" suffix="мм" :rules="doubleFieldValidationRules"></v-text-field>
            <v-text-field label="Голень" suffix="мм" :rules="doubleFieldValidationRules"></v-text-field>
          </v-layout>
        </v-flex>
      </v-layout>
    </v-form>
  </v-container>
</template>

<script>
export default {
  data () {
    return {
      bodyTypes: ['Нормостеник', 'Астеник', 'Гиперстеник'],
      spineTypes: ['Нормальная', 'Плоская', 'Сутулая', 'Лордическая'],
      formValid: false,
      doubleFieldValidationRules: [
        value => !isNaN(value) || 'Значение должно быть числом'
      ]
    }
  },
  props: {
  },
  methods: {},
  tabText: 'Физическое развитие',
  name: 'PhysicalDevelopment'
}
</script>
