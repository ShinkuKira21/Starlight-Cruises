<script lang="ts">

</script>

<template>
  <section id="brand">
    <div class="brand text-center">
      <img src="assets/logo/logo.png"/>
    </div>
    
    <div id="brand-details" class="parent-container d-flex">
      <div id="img" class="container">
        <div class="row">
          <div class="col">
            <img width="500px" src="assets/placeholders/placeholder.jpg" alt="Placeholder Image"/>
          </div>
        </div>
      </div>
      <div id="info" class="container">
        <div class="row">
          <div class="col">
            <h2>Locations</h2>
            <p>There is just enough space here for several lines of text. Make sure you get your message across clearly yet concisely.</p>
          </div>
        </div>
        <div class="row">
          <div class="col">
            <h2>Prices</h2>
            <p>There is just enough space here for several lines of text. Make sure you get your message across clearly yet concisely.</p>
            <br/>
            <p>There is just enough space here for several lines of text. Make sure you get your message across clearly yet concisely.</p>
          </div>
        </div>
      </div>
    </div>
  </section>
</template>

<style scoped>
  h1, h2, p {
    color: white;
  }

  .brand h1 {
    text-align: center;
  }
  
  #brand-details {
    padding-top: 100px;
  }
  
  #brand-details > #img {
    padding-left: 20px;
    margin-left: 150px;
  }
  #brand-details > #info {
    padding-right: 100px;
    margin-right: 150px;
  }
</style>