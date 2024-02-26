<html>
<body> 

<?php 


$client=$_POST['nome'];
$email=$_POST['email'];
$telef=$_POST['telef'];
$pais=$_POST['pais'];
$nameError="";
$emailError="";
$telefError="";
$paisError="";


echo $nome;

if (!$nome) {
	echo 'Nome em falta, preencha o nome';
	exit;
}

if (!$email) {
	echo 'Email em falta, preencha o email';
	exit;
}

if (!$telef) {
	echo 'Telefone em falta, preencha o Telefone';
	exit;
}

if (!$pais) {
	echo 'País em falta, preencha o pais';
	exit;
}



echo 'Dados recebidos: <br />';
echo 'Nome: '.$nome.' <br />';
echo 'Email:'.$email.' <br />';
echo 'Telefone:'.$telef.'<br />';
echo 'País:'.$pais.' <br />';

$conn=mysqli_connect('localhost','root',null,'voluntarios') or die (mysqli_connect_error()); 

if (!$conn) {
	die("Falha de conexão:" .mysqli_connect_error());
}

$sql = "INSERT INTO contactos (nome,email,telef,pais) VALUES ('".$nome."', '".$email."', '".$telef."', '".$pais."')";

if (mysqli_query($conn,$sql)) {
	echo "Candidatura realizada com sucesso"; 
} else {
	echo "Erro:" .$sql. "<br>" .mysqli_error($conn);
}

mysqli_close($conn);


?> 



<p></p>
<a href="http://localhost/PHP_project/index.html">
		Voltar à entrada </a>

</body>
</html>




