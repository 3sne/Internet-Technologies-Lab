## NOTE
To remove the ugly default .NET styling, you can use the css classes in the `ext/` directory. <br>
It contains minified precompiled css and js from the boostrap library.<br>
<hr>

### Sample Usage

```html
<html>
<head runat="server">
    <link href="ext/css/bootstrap.min.css" rel="stylesheet">
</head>
<body>
    
    <!-- 
        form content
     -->
    
    <script type="text/javascript" src="ext/js/jquery-3.4.1.min.js"></script>
    <script type="text/javascript" src="ext/js/popper.min.js"></script>
    <script type="text/javascript" src="ext/js/bootstrap.min.js"></script>
</body>
</html>
```

<hr>

### Lab 6
* Validation Controls use `visibility:hidden;` by default. This leads to element taking up on-screen real-estate. To make this better, set `Display="Dynamic"` on every Validation Control. This hides the inactive element at block level. Also, set `Display="None"` to not show individual errors, in case `ValidationSummary` is used.  

* To remedy `UnobtrusiveValidationMode` server error, paste the following key in `web.config`:
    ```as
    <configuration>
        <appSettings>
            <add 
                key="ValidationSettings:UnobtrusiveValidationMode" 
                value="None" />
        </appSettings>
    </configuration>
    ```