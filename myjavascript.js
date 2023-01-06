console.log("hello world");
const img = new Image();
img.onload = function() {
  console.log(this.width + 'x' + this.height);
}
img.src = 'photoofme.png';