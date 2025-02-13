<html>
<head>
    <title>Redball</title>
    <style>
        #redball {
        position: absolute;
        left: 100px;
        top: 100px;
        width: 100px;
        height: 100px;
        }
    </style>
</head>
<body>
    <img id="redball" src="Red-Ball-3D-Transparent-PNG.png">
    <script>
        var redball = document.getElementById("redball");
        function moveBall(e)
            var left = parseInt(redball.style.left) || 100;
            var top = parseInt(redball.style.top) || 100;

            if (e.keyCode == 37) // Left Arrow
                redball.style.left = (left - 10) + "px";
            
            if (e.keyCode == 38) // Up Arrow
                redball.style.top = (top - 10) + "px";
            
            if (e.keyCode == 39) // Right Arrow
                redball.style.left = (left + 10) + "px";
            
            if (e.keyCode == 40) // Down Arrow
                redball.style.top = (top + 10) + "px";
            
    </script>

</body>
</html>