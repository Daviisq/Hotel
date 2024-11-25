<?php

include_once "conexao.php";
if (isset($_POST['submit'])) {
    $usuario = $_POST['usuario'];
    $email = $_POST['email'];
    $senha = $_POST['senha'];

   

   

    $enviar = mysqli_query($conexao,"INSERT INTO cliente(nome_cli,email_cli,senha_cli) VALUES ('$usuario','$email','$senha') ");
}
?>
