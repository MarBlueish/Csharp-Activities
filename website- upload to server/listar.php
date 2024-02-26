<html>
<body>

<?php 

echo "<h3> Lista de contactos </h3>";

$conn=mysqli_connect('localhost','root',null,'voluntarios') or die (mysqli_connect_error());

if (!$conn) {
	die ("Falha de conexão: " . mysqli_connect_error());
}

$sql = "SELECT * from contactos";
$result = $conn ->query($sql);

if ($result->num_rows > 0) {
	while($row = $result->fetch_assoc()) {
		echo "Nome:" . $row["nome"]. "Email" .$row["email"] . $row["telef"]. "Pais" . $row["pais"] . "<br>";
	}
} else { 
	echo "BD vazia";
}
mysqli_close($conn);
?>
<p> </p>
<a href="http://localhost/PHP_project/index.html">
Voltar à entrada </a>

</body>
</html>