$(document).ready(function () {
    $("#0").click(function () {
        var myGame = new Game();
        let playersMove = 0;

        myGame.CompareMoves(playersMove);
    });

    $("#1").click(function () {
        var myGame = new Game();
        let playersMove = 1;

        myGame.CompareMoves(playersMove);
    });

    $("#2").click(function () {
        var myGame = new Game();
        let playersMove = 2;

        if (myGame.myPlayer.playersSavedSnowballs > 0 && myGame.myPlayer.playersSavedSnowballs < 3) {
            myGame.CompareMoves(playersMove);
        }
        else if (myGame.myPlayer.playersSavedSnowballs > 2) {
            $("#responseDiv").text("GAME OVER ---- You won! ");
            myGame.AddPlayAgainButton();
        }
        else $("#responseDiv").text("You have nothing to throw, select Squeeze or Block");
    });
});