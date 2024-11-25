<style>

    #navbar {
      z-index: 1030 !important; 
    }

    .offcanvas {
      z-index: 1050 !important; 
      position: fixed; 
    }


    .offcanvas-backdrop {
      display: none !important; 
    }

</style>

  <header>

    <nav class="navbar  bg-black bg-opacity-50 fixed-top" id="navbar">



      <div class="container-fluid">
        <a class="navbar-brand fs-2" href="#"><strong>Hotel Skyline⭐</strong> conforto & qualidade</a>
        <button class="navbar-toggler" type="button" data-bs-toggle="offcanvas" data-bs-target="#offcanvasNavbar" aria-controls="offcanvasNavbar" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>

        <div class="offcanvas offcanvas-end" tabindex="-1" id="offcanvasNavbar" aria-labelledby="offcanvasNavbarLabel">
          <div class="offcanvas-header">
            <h5 class="offcanvas-title" id="offcanvasNavbarLabel">Hotel Skyline⭐ conforto & qualidade</h5>
            <button type="button" class="btn-close" data-bs-dismiss="offcanvas" aria-label="Close"></button>
          </div>

          <div class="offcanvas-body">
            <ul class="navbar-nav justify-content-end flex-grow-1 pe-3">
              <li class="nav-item"><a class="nav-link active" aria-current="page" href="#">Início</a></li>
              <li class="nav-item"><a class="nav-link" href="./login.php ">Perfil do Hospede</a></li>
              <li class="nav-item"><a class="nav-link" href="#">Perfil do Funcionário</a></li>
              <li class="nav-item"><a class="nav-link" href="#">Serviços</a></li>

              <li class="nav-item dropdown">
                <a class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="true">Sobre nós</a>
                <ul class="dropdown-menu">
                  <li><a class="dropdown-item" href="#quemsomos">Quem Somos</a></li>
                  <li><a class="dropdown-item" href="#missao">Missão</a></li>
                  <li><a class="dropdown-item" href="#visao">Visão</a></li>
                  <li><a class="dropdown-item" href="#valores">Valores</a></li>
                </ul>
              </li>
              <li class="nav-item"><a class="nav-link" href="#">Contato</a></li>
            </ul>
          </div>
        </div>
      </div>
    </nav>
  </header>

  <script>
      const offcanvas = document.getElementById('offcanvasNavbar');
      const blurOverlay = document.getElementById('blur-overlay');

      offcanvas.addEventListener('show.bs.offcanvas', () => {
        blurOverlay.classList.add('show'); 
      });

      offcanvas.addEventListener('hidden.bs.offcanvas', () => {
        blurOverlay.classList.remove('show'); 
      });
  </script>