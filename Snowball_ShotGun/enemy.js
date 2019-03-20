class Enemy {
    constructor(){
        this.enemysMoveList = ["SQUEEZE", "BLOCK", "THROW"];
        this.enemysSavedSnowballs = $("#enemyPlayerSnowballs").text();
        this.enemysMove = this.MoveRandom();
    }

    MoveRandom() {
        let move = Math.floor((Math.random() * 3));

        if (move == 2 && this.enemysSavedSnowballs < 1) {
            console.log("Fienden har inga snöbollar att kasta! Slumpar ett nytt drag mellan 0-1");
            move = Math.floor((Math.random() * 2));
        }
        else if (move == 2 && this.enemysSavedSnowballs > 2) { 
            $("#responseDiv").text("GAME OVER ---- You lost...");
            myGame.AddPlayAgainButton();
        }
        let enemysMoveText = this.enemysMoveList[move];

        $("#enemysMoveDiv").text("Enemy's move: " + enemysMoveText);

        return move;
    }
}