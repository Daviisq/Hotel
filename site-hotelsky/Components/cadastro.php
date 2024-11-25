
<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>login</title>
    <style>
   
        body {
            font-family: 'Arial', sans-serif;
            background: url('homeee.png') no-repeat center center fixed;
            background-size: cover;
            margin: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

   
        .container {
            display: flex;
            width: 900px;
            background-color: #ffffff;
            border-radius: 15px;
            overflow: hidden;
            box-shadow: 0 4px 20px rgba(0, 0, 0, 0.2);
        }

       
        .intro {
            flex: 1;
            background-color: #635dff;
            color: #fff;
            display: flex;
            flex-direction: column;
            justify-content: center;
            align-items: center; 
            text-align: center;
            padding: 40px;
        }

        .intro img {
            max-width: 80%;
            margin-bottom: 20px;
            border-radius: 40px;
        }

        .intro p {
            font-size: 1.2rem;
            line-height: 1.6;
            margin: 0;
        }

       
        .login {
            flex: 1;
            padding: 40px;
            display: flex;
            flex-direction: column;
            justify-content: center;
        }

        .login h2 {
            font-size: 2rem;
            color: #333;
            margin-bottom: 20px;
        }

        .login form {
            display: flex;
            flex-direction: column;
        }

        .login label {
            font-size: 1rem;
            color: #555;
            margin-bottom: 8px;
        }

        .login input {
            font-size: 1rem;
            padding: 10px;
            margin-bottom: 15px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }

        .login input[type="submit"] {
            background-color: #635dff;
            color: #fff;
            border: none;
            cursor: pointer;
            padding: 12px;
            border-radius: 5px;
            font-weight: bold;
            transition: background-color 0.3s;
        }

        .login input[type="submit"]:hover {
            background-color: #5043c8;
        }

        .login a {
            font-size: 0.9rem;
            color: #635dff;
            text-decoration: none;
            margin-top: 10px;
            text-align: center;
        }

        .login a:hover {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <div class="container">
        <div class="intro">
            <img src="imagecopy.png" alt="Ilustração">
            <p>
                Seja bem-vindo, acesse e aproveite todo o conteúdo. Somos uma equipe de profissionais
                empenhados em trazer o melhor conteúdo direcionado a você! ⭐
            </p>
        </div>
        <div class="login">
            <h2>Faça Seu Login !</h2>
            <form action="verificar.php" method="POST">
                <label for="usuario">Usuário:</label>
                <input type="text" id="username" name="usuario" required>

                <label for="email">E-mail:</label>
                <input type="email" id="email" name="email" required>

                <label for="senha">Senha:</label>
                <input type="password" id="senha" name="senha" required>

                <input type="submit" name="submit" value="Logar">
            </form>
            <a href="/site-hotelsky/registro.php">Não tem uma conta? Faça o cadastro</a>
        </div>
    </div>
</body>
</html>