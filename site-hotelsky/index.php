
<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Skyline</title>
    <link rel="stylesheet" href="./styles/carrouselProdutos.css">
    <link rel="stylesheet" href="./styles/style.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    
</head>



<body data-bs-theme="dark">
<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/umd/popper.min.js" integrity="sha384-I7E8VVD/ismYTF4hNIPjVp/Zjvgyol6VFvRkX/vR+Vc4jQkC+hVqc2pM8ODewa9r" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.min.js" integrity="sha384-0pUGZvbkm6XF6gxjEnlmuGrJXVbNuzT9qBBavbLwCsOGabYfZo0T0to5eqruptLy" crossorigin="anonymous"></script>

  <?php 
    include_once "./Components/menu.php";
    include_once './Components/carrousel.php';    
  ?>

    <section id="quemsomos" class="p-3 text-center center ">
      <div class="container">
        <div class="row align-items-center center">
          </div>
          <div class="col-md-6">
         </div>
            <h3 class="mb-4">QUEM SOMOS?</h3>
            <p>
              O Hotel Skyline, situado no centro de São Paulo, é um refúgio de conforto e qualidade em meio à agitação urbana. Localizado próximo à estação Brigadeiro, na movimentada Avenida Paulista, o hotel oferece fácil acesso aos principais pontos turísticos, centros culturais e áreas de negócios da capital paulista.
            </p>
            <p>
              Atuando no setor hoteleiro, o Skyline é uma organização de porte médio e de sociedade limitada (LTDA), que se destaca pelo serviço atencioso e personalizado, além dos espaços comuns meticulosamente mantidos para proporcionar uma experiência única aos hóspedes. A combinação de sua localização privilegiada e seu compromisso com a excelência garante que os visitantes possam aproveitar ao máximo a acelerada cidade de São Paulo.
            </p>
          </div>
        </div>
      </div>
    </section>
    
    <!-- Cards -->
    <div data-bs-theme="light" class=" my-5 d-flex gap-3 justify-content-center">

      <div id="missao" class="card rounded-4 overflow-hidden" style="width:18rem;">
        <img src="./img/missao.jpg" class="card-img-top object-fit-cover mw-100" alt="...">
        <div class="card-body text-center">
          <h5 class="card-title">MISSÃO</h5>
          <p class="card-text">Oferecer uma experiência única de conforto, qualidade e hospitalidade, com atendimento personalizado e excelência, garantindo uma estadia memorável.</p>
        </div>
      </div>

      <div id="visao" class="card rounded-4 overflow-hidden" style="width:18rem;">
        <img src="./img/visao.jpg" class="card-img-top" alt="...">
        <div class="card-body text-center">
          <h5 class="card-title">VISÃO</h5>
          <p class="card-text">Ser reconhecido como o hotel de referência na região, destacando-se pela qualidade, inovação e compromisso com a satisfação dos clientes.</p>
        </div>
      </div>

      <div id="valores" class="card rounded-4 overflow-hidden" style="width:18rem;">
        <img src="./img/valores.png" class="card-img-top" alt="...">
        <div class="card-body text-center">
          <h5 class="card-title">VALORES</h5>
          <p class="card-text">Hospitalidade, excelência e colaboração guiam nossas ações para oferecer uma experiência excepcional aos hóspedes e um ambiente de trabalho harmonioso.</p>
        </div>
      </div>
    </div>

    <section class="container my-5 d-flex gap-3  border-0" data-bs-theme="light">
    
      <div class="card rounded-4 overflow-hidden border-0" style="width:40rem;">
        <div class="card-body">
          <h1>Áreas do Hotel</h1>
          <ul class="list-group w-100 list-group-flush">
            <li class="list-group-item">- Restaurantes e Bares</li>
            <li class="list-group-item">- Área de Lazer (piscinas, academias e spa)</li>
            <li class="list-group-item">- Área ao Ar Livre (jardim)</li>
            <li class="list-group-item">- Serviços de Lavanderia e Limpeza.</li>
            <li class="list-group-item">- Área de estacionamento.</li>
          </ul>
        </div>
      </div>

      <div style="height: 100%;">
        <div class=" overflow-hidden rounded-4 h-auto" >
          <div class="row ">
            <div class="col p-0">
              <img src="./img/areas-hotel/1.jpeg" class="img-fluid " alt="Imagem 1">
            </div>
            <div class="col p-0">
              <img src="./img/areas-hotel/2.jpg" class="img-fluid " alt="Imagem 2">
            </div>
          </div>

          <div class="row ">
            <div class="col p-0">
              <img src="./img/areas-hotel/3.jpeg" class="img-fluid " alt="Imagem 3">
            </div>
            <div class="col p-0">
              <img src="./img/areas-hotel/4.jpeg" class="img-fluid " alt="Imagem 4">
            </div>
          </div>
        </div>
      </div>



    </section>

    <section class="container my-5 d-flex gap-3  border-0" data-bs-theme="light">

      <div style="height: 100%;">
        <div class=" overflow-hidden rounded-4 h-auto" >
          <div class="row ">
            <div class="col p-0">
              <img src="./img/areas-hotel2/1.jpeg" class="img-fluid " alt="Imagem 1">
            </div>
            <div class="col p-0">
              <img src="./img/areas-hotel2/2.jpeg" class="img-fluid" alt="Imagem 2">
            </div>
          </div>

          <div class="row ">
            <div class="col p-0">
              <img src="./img/areas-hotel2/3.jpeg" class="img-fluid " alt="Imagem 3">
            </div>
            <div class="col p-0">
              <img src="./img/areas-hotel2/4.jpeg" class="img-fluid " alt="Imagem 4">
            </div>
          </div>
        </div>
      </div>

      <div class="card rounded-4 overflow-hidden border-0" style="width:40rem;">
        <div class="card-body">
          <h1>Áreas do Hotel</h1>
          <ul class="list-group w-100 list-group-flush">
            <li class="list-group-item">- 40 quartos sendo divididos em: 10 suítes (cama de casal mais cama de solteiro);</li>
            <li class="list-group-item">- 20 quartos com cama de casal;</li>
            <li class="list-group-item">- 10 quartos com camas de solteiro.</li>

          </ul>
        </div>
      </div>  

    </section>

    <?php
      include_once './Components/footer.php'
    ?>
</body>
</html>