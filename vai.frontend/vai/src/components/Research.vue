<template>
  <v-container fluid>
    <v-tabs dark>
      <v-tab v-for="component in components" :key="component.tabText" ripple>
        {{component.tabText}}
      </v-tab>
      <v-tab-item v-for="component in components" v-bind:key="component.name">
        <v-card flat>
          <component :is="component"></component>
        </v-card>
      </v-tab-item>
    </v-tabs>
  </v-container>
</template>

<script>
import PhysicalDevelopmentTab from './PhysicalHealthTabs/PhysicalDevelopment'
import PhysicalStateTab from './PhysicalHealthTabs/PhysicalState'
import PhysicalOpportunities from './PhysicalHealthTabs/PhysicalOpportunities'
import WorkingCapacity from './PhysicalHealthTabs/WorkingCapacity'
import PhysicalReadiness from './PhysicalHealthTabs/PhysicalReadiness'
export default {
  data () {
    return {
      components: [
        PhysicalDevelopmentTab,
        PhysicalStateTab,
        PhysicalOpportunities,
        WorkingCapacity,
        PhysicalReadiness
      ]
    }
  },
  components: {
    PhysicalDevelopmentTab,
    PhysicalStateTab,
    PhysicalOpportunities,
    WorkingCapacity,
    PhysicalReadiness
  },
  methods: {},
  name: 'Research'
}
</script>