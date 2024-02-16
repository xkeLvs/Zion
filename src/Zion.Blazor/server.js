const express = require('express');
const path = require('path');
const app = express();

// Serve static files from the wwwroot directory
app.use(express.static(path.join(__dirname, 'wwwroot')));

// Start the server
const port = process.env.PORT || 3000;
app.listen(port, () => console.log(`Server started on port ${port}`));