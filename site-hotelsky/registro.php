
<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Cadastro</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <style>
    

.form-container {
    background-color: #333;
    padding: 20px;
    border-radius: 10px;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
    color: #ffffff;
}

form {
    display: flex;
 
}



input[type="text"],
input[type="email"],
input[type="password"] {
    padding: 10px;
    margin-bottom: 10px;
    border: 1px solid #ccc;
    border-radius: 5px;
    background-color: #444;
    color: #ffffff;
}

input[type="submit"] {
    padding: 10px;
    border: none;
    border-radius: 5px;
    background-color: #4CAF50;
    color: white;
    cursor: pointer;
    transition: background-color 0.3s;
}

input[type="submit"]:hover {
    background-color: #45a049;
}

    </style>
    <h2>Cadastro</h2>
    <form action="rgst.php" method="POST">
        <label for="usuario">Usuário:</label>
        <input type="text" id="usuario" name="usuario" required>

        <label for="email">E-mail:</label>
        <input type="email" id="email" name="email" required>

        <label for="senha">Senha:</label>
        <input type="password" id="senha" name="senha" required>


        <input type="submit" name="submit" style="background-color: yellow;" Cadastrar>
    </form>

    <p><a href="Components/cadastro.php">Já tem uma conta? Faça login</a></p>
</body>
</html>
