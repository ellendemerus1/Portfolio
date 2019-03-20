class Game {
    constructor() {
        this.myPlayer = new Player();
        this.myEnemy = new Enemy();
    }

    CompareMoves(playersMove) {
        let enemyMove = this.myEnemy.enemysMove;
        let playerSnowballs = this.myPlayer.playersSavedSnowballs;
        let enemySnowballs = this.myEnemy.enemysSavedSnowballs;

        if (playersMove == 0 && enemyMove == 0) {
            playerSnowballs++;
            enemySnowballs++;
        }
        else if (playersMove == 0 && enemyMove == 1) {
            playerSnowballs++;
        }
        else if (playersMove == 0 && enemyMove == 2) {
            $("#responseDiv").text("GAME OVER ---- You lost... ");
            this.AddPlayAgainButton();
        }
        else if (playersMove == 1 && enemyMove == 0) {
            enemySnowballs++;
        }
        else if (playersMove == 1 && enemyMove == 2) {
            enemySnowballs--;
        }
        else if (playersMove == 2 && enemyMove == 0) {
            $("#responseDiv").text("GAME OVER ---- You won! ");
            this.AddPlayAgainButton();
        }
        else if (playersMove == 2 && enemyMove == 1) {
            playerSnowballs--;
        }
        else if (playersMove == 2 && enemyMove == 2) {
            playerSnowballs--;
            enemySnowballs--;
        }

        if (playerSnowballs > 2 && enemySnowballs > 2) {
            $("#responseDiv").text("SHOTGUN OVERLOAD! No winner - click to start a new round");
            this.AddPlayAgainButton();
        }
        else if (playerSnowballs > 2) $("#responseDiv").text("SHOTGUN! You have 3 snowballs - THROW and you'll win.");
        else if (enemySnowballs > 2) $("#responseDiv").text("ENEMY'S SHOTGUN! Your enemy has 3 snowballs - if enemy THROWS you will loose...");

        $("#playerSnowballs").text(playerSnowballs);
        $("#enemyPlayerSnowballs").text(enemySnowballs);
    }

    AddPlayAgainButton() {
        let newButton = document.createElement("button");
        let buttonText = document.createTextNode("PLAY AGAIN?");
        newButton.appendChild(buttonText);

        newButton.addEventListener("click", function () {
            location.reload();
        })

        document.getElementById("responseDiv").appendChild(newButton);
    }
}