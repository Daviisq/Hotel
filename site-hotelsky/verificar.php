<?php
session_start();

if(isset($_POST['submit'])){
include_once 'conexao.php';
$email=$_POST['email'];
$senha=$_POST['senha'];


$sql= "SELECT * FROM cliente WHERE email_cli ='$email' and senha_cli='$senha' ";
$enviar=$conexao->query($sql);
//print_r($enviar);
if(mysqli_num_rows($enviar) <1) {
    unset( $_SESSION['email']);
    unset($_SESSION['senha']);
    header('Location: erro.php');
}
else{
    $_SESSION['email']= $email;
    $_SESSION['senha']= $senha;
    header('Location: index.php');
}
}else{
    header('Location: erro.php');
}
?>