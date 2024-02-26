<html>
<body>
	<meta charset="utf-8">
	<h2> Remover contacto </h2>

<?php 

echo 'Rotina para remover contacto <p>';

$nome = $_POST['nome'];


if (!$nome) {
	echo 'Nome em falta, preencha o nome.';
	exit;
}

echo 'Contacto a remover:' .$nome. '<p>';

$conn=mysqli_connect('localhost','root',null,'voluntarios') or die (mysqli_connect_error());

if(!$conn) {
	die("Falha de conexão: " . mysqli_connect_error());
}

$sql = "DELETE FROM contactos WHERE nome = '" .$nome . "'";

if ($conn->query($sql) === TRUE) {
	echo "Contacto apagado com sucesso";
} else {
	echo "Error ao remover o contacto:" . $conn->error;
}

mysqli_close($conn); 

?>

<p></p>
<a href="http://localhost/PHP_project/index.html">
Voltar à entrada </a>

</body>
</html>


