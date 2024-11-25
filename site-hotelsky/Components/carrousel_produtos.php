
<?php

$Title = "Hoteis: ";  
$Card = [
    ['imagem' => 'https://www.bing.com/images/search?view=detailV2&ccid=ndA2U6Zb&id=9B067B288B3C1091506813B7173D338A3D8EAD5D&thid=OIP.ndA2U6ZbObeRo-qLSurDPgHaE8&mediaurl=https%3a%2f%2fdynamic-media-cdn.tripadvisor.com%2fmedia%2fphoto-o%2f0e%2fa3%2fd7%2f77%2fexterior-entrance.jpg%3fw%3d1200%26h%3d-1%26s%3d1&cdnurl=https%3a%2f%2fth.bing.com%2fth%2fid%2fR.9dd03653a65b39b791a3ea8b4aeac33e%3frik%3dXa2OPYozPRe3Ew%26pid%3dImgRaw%26r%3d0&exph=800&expw=1200&q=Hotel&simid=608020155743099352&FORM=IRPRST&ck=CEF1952DE7219C16A90AED88BA4BDC4F&selectedIndex=1&itb=0', 'title' => 'Hotel 1', 'subTitle' => '2 suites, 1 sala', 'descricao' => null,], 
    ['imagem' => 'https://www.cerave.com.br/-/media/project/loreal/brand-sites/cerave/americas/br/scx/thumbnail-images/moisturising-cream-thumb.png?rev=-1?w=250&hash=DEBA08BA406FA526D2361C2302D4911D', 'title' => 'Hidratação corporal', 'subTitle' => null, 'descricao' => null],
    ['imagem' => 'https://www.cerave.com.br/-/media/project/loreal/brand-sites/cerave/americas/br/scx/thumbnail-images/gel-de-limpeza-thumb.png?rev=-1?w=250&hash=95375B707BD592EF06EB74627CFD61A9', 'title' => 'limpeza Facial', 'subTitle' => null, 'descricao' => null],
    ['imagem' => 'https://www.cerave.com.br/-/media/project/loreal/brand-sites/cerave/americas/br/scx/thumbnail-images/foaming-oil-cleanser-thumb.png?rev=-1?w=250&hash=D16DDDA74554EEB269529CE90249D0D5', 'title' => 'Limpeza Corporal', 'subTitle' => null, 'descricao' => null],
    ['imagem' => 'https://www.cerave.com.br/-/media/project/loreal/brand-sites/cerave/americas/br/scx/thumbnail-images/acne-thumb.png?rev=-1?w=250&hash=F0F75844B896EFAED1BFBC2214CE4977', 'title' => 'Acne', 'subTitle' => null, 'descricao' => null],
    ['imagem' => 'assets\imagens\produtos\oil-control-1-LG-removebg-preview.png', 'title' => 'Loção Facial Oil Control', 'subTitle' =>  NULL, 'descricao' => null],
    ['imagem' => 'assets\imagens\produtos\oil-control-1-LG-removebg-preview.png', 'title' => 'Loção Facial Oil Control', 'subTitle' =>  NULL, 'descricao' => null],
    ['imagem' => 'assets\imagens\produtos\oil-control-1-LG-removebg-preview.png', 'title' => 'Loção Facial Oil Control', 'subTitle' =>  NULL, 'descricao' => null],
    ['imagem' => 'assets\imagens\produtos\oil-control-1-LG-removebg-preview.png', 'title' => 'Loção Facial Oil Control', 'subTitle' =>  NULL, 'descricao' => null],

];
?>

<style>

    #scrollContainer {
      scroll-behavior: initial; 
      column-gap: 10px; 
      height: 100% !important;
      overflow: hidden; 
    }

    .card {
      cursor: pointer;
      min-width: 200px;  
      border-radius: 15px;
      transition: 0.3s;
      transform-origin: center; 
    }
    

</style>

<div class="container m-5">
    <h1 class="title m-0"><?php echo $Title; ?></h1>
  </div>

<div class="align-items-center justify-content-center d-flex position-relative" style="width: 100%; overflow: hidden; height: 400px">


    <button id="scrollLeft" class="btn btn-custom carousel-control-prev">
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
  
  <div id="scrollContainer" class="d-flex p-3">

    <?php 
        foreach ($Card as $index => $Card): 
    ?>
      <div 
      <?php echo ($index == 0 ? 'class="card ms-5"' : ($index == 8 ? 'class="card me-5"' : 'class="card"')) . '"'; ?>
      >
        <img <?php echo 'src="' . $Card['imagem'] . '"'; ?>  class="card-img-top p-3" alt="...">
        <div class="card-body">
          <h5 class="card-title text-center"><?php echo $Card['title']?></h5>
          <h6 class="card-subtitle mb-2 text-muted "><?php $Card['subTitle']?></h6>
          <p class="card-text"><?php echo $Card['descricao']?></p>
          
        </div>
      </div>
        
    <?php 
        endforeach; 
    ?>

  </div>

    <button id="scrollRight" class="btn btn-custom carousel-control-next">
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

<script>
  document.getElementById('scrollLeft').addEventListener('click', function() {
    const scrollContainer = document.getElementById('scrollContainer');
    scrollContainer.scrollBy({
      left: -300,
      behavior: 'smooth'
    });
  });

  document.getElementById('scrollRight').addEventListener('click', function() {
    const scrollContainer = document.getElementById('scrollContainer');
    scrollContainer.scrollBy({
      left: 300,
      behavior: 'smooth'
    });
  });
</script>
