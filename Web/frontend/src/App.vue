<script setup lang="ts">
  import 'bootstrap/dist/css/bootstrap.css';
  import 'bootstrap/dist/js/bootstrap.js';
  
  import Brand from '../components/Brand.vue';
</script>

<template>
  
  <Brand id="brand-view"/>
</template>

<style scoped>
  #brand-view {
    background-image: url("assets/backgrounds/02.png");
    background-repeat: no-repeat;
    background-size: cover;
    min-height: 100vh;
  }
</style>
