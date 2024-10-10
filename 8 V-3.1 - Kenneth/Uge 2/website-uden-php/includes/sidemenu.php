<nav class="side">
    <a href="index.php"><img src="img/edea-skates-logo.png" alt="Edea logo"></a>
    <ul>
        <li><a href="index.php">Forside</a></li>
        <li><a href="shop.php">Shop</a></li>
        <li><a href="createuser.php">Opret bruger</a></li>
        <?php
        if(isset($_SESSION['login-username'])) {
            echo "<li><a href='logout.php'>Log ud</a></li>";
        }
        else {
            echo "<li><a href='login.php'>Log ind</a></li>";
        }
        ?>  
    </ul>
</nav>