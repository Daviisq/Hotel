<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login</title>
</head>
<style>
    /* styles.css */
body {
    font-family: Arial, sans-serif;
    background-color: #f0f0f0;
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
    margin: 0;
}

.form-container {
    background-color: #333;
    padding: 20px;
    border-radius: 10px;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
    color: #ffffff;
}

form {
    display: flex;
    flex-direction: column;
}

h2 {
    margin-bottom: 20px;
    text-align: center;
}

label {
    margin: 10px 0 5px 0;
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
<body>
    <form action="verificar.php" method="post">
        <label for="usuario">Usuário:</label>
        <input type="text" id="usuario" name="usuario" required><br>

        <label for="email">Email:</label>
        <input type="email" id="email" name="email" required><br>

        <label for="senha">Senha:</label>
        <input type="password" id="senha" name="senha" required><br>

        <input type="submit" name="submit" value="Entrar">
        <p><a href="registro.php">Não tem uma conta? Faça seu Cadastro </a></p>
    </form>
</body>
</html>
