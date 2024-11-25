<style>
  /*deixar texto em branco*/
  #carouselExampleCaptions .carousel-caption {
    color: white; 
  }

  #carouselExampleCaptions .carousel-indicators button {
    background-color: white; 
  }

  #carouselExampleCaptions .carousel-indicators .active {
    background-color: #ffffff;  
  }

  #carouselExampleCaptions .carousel-control-prev-icon,
  #carouselExampleCaptions .carousel-control-next-icon {
    background-color: rgba(255, 255, 255, 0.5); 
    border-radius: 50%;
  }

  #carouselExampleCaptions .visually-hidden {
    color: white;
  }
</style>



<div id="carouselExampleCaptions" class="carousel slide">

  <!-- Botões da parte inferior do carousel -->
  <div class="carousel-indicators">
    <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
    <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="1" aria-label="Slide 2"></button>
    <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="2" aria-label="Slide 3"></button>
  </div>

  <!-- Imagens do Carousel -->
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img src="./img/homeee.png" class="d-block w-100" alt="...">
      <div class="carousel-caption d-none d-md-block">
        <h5 class="text-light">Seja Bem-Vindo(a)</h5>
        <p class="text-light">Aqui te proporcionamos o melhor</p>
      </div>
    </div>

    <div class="carousel-item">
      <img src="./img/jantar.png" class="d-block w-100" alt="...">
      <div class="carousel-caption d-none d-md-block">
        <h5 class="text-light">Sala de Jantar</h5>
        <p class="text-light">Sempre pensando no seu conforto!</p>
      </div>
    </div>

    <div class="carousel-item">
      <img src="./img/quartosolteiro.jpg" class="d-block w-100" alt="...">
      <div class="carousel-caption d-none d-md-block">
        <h5 class="text-light">Quarto com vista</h5>
        <p class="text-light">Qualidade em nossos serviços!</p>
      </div>
    </div>
  </div>

  <!-- Botões de Navegação -->
    <button id="prev" class="carousel-control-prev btn btn-custom" type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide="prev">
      <svg style="color: blue; fill: blue" height="2em" viewBox="0 0 7 12" xmlns="http://www.w3.org/2000/svg">
          <g id="Icons" stroke="none" stroke-width="1" fill="none" fill-rule="evenodd">
            <g id="Rounded" transform="translate(-652.000000, -2464.000000)">
              <g id="Hardware" transform="translate(100.000000, 2404.000000)">
                <g id="-Round-/-Hardware-/-keyboard_arrow_left" transform="translate(544.000000, 54.000000)">
                  <g>
                    <rect id="Rectangle-Copy-104" x="0" y="0" width="50" height="50"></rect>
                    <path d="M14.71,15.88 L10.83,12 L14.71,8.12 C15.1,7.73 15.1,7.1 14.71,6.71 C14.32,6.32 13.69,6.32 13.3,6.71 L8.71,11.3 C8.32,11.69 8.32,12.32 8.71,12.71 L13.3,17.3 C13.69,17.69 14.32,17.69 14.71,17.3 C15.09,16.91 15.1,16.27 14.71,15.88 Z" id="Icon-Color"></path>
                  </g>
                </g>
              </g>
            </g>
          </g>
      </svg>
    </button>

    <button id="next" class="carousel-control-next btn btn-custom" type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide="next">
      <svg height="2em" viewBox="0 0 7 12" xmlns="http://www.w3.org/2000/svg">
          <g id="Icons" stroke="none" stroke-width="1" fill="none" fill-rule="evenodd">
            <g id="Rounded" transform="translate(-687.000000, -2464.000000)">
              <g id="Hardware" transform="translate(100.000000, 2404.000000)">
                <g id="-Round-/-Hardware-/-keyboard_arrow_right" transform="translate(578.000000, 54.000000)">
                  <g>
                    <rect id="Rectangle-Copy-105" x="0" y="0" width="50px" height="50px"></rect>
                    <path d="M9.29,15.88 L13.17,12 L9.29,8.12 C8.9,7.73 8.9,7.1 9.29,6.71 C9.68,6.32 10.31,6.32 10.7,6.71 L15.29,11.3 C15.68,11.69 15.68,12.32 15.29,12.71 L10.7,17.3 C10.31,17.69 9.68,17.69 9.29,17.3 C8.91,16.91 8.9,16.27 9.29,15.88 Z" id="Icon-Color"></path>
                  </g>
                </g>
              </g>
            </g>
          </g>
        </svg>
    </button>
</div>
