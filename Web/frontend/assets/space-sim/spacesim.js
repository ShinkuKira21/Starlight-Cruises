import * as tjs from "three";

let scene, camera, renderer, starGeo, stars;

function init() {
    scene = new tjs.Scene();
    camera = new tjs.PerspectiveCamera(60, window.innerWidth / window.innerHeight, 1, 1000);
    camera.position.z = 1;
    camera.position.x = Math.PI/2;
    
    renderer = new tjs.WebGLRenderer();
    renderer.setSize(window.innerWidth, window.innerHeight);
    document.body.appendChild(renderer.domElement);
    
    starGeo = new tjs.BufferGeometry();

    let vertices = new Float32Array(6000*2);
    for(let i = 0; i < 6000; i++) {
        
       
        for(let j = 0; j < 6000; j++) {
            vertices[j] = Math.random() * 600 - 300;
        }

        
    }
    starGeo.setAttribute("position", new tjs.BufferAttribute(vertices, 3));
    
    let sprite = new tjs.TextureLoader().load('/img/star.png');
    let starMaterial = new tjs.PointsMaterial({
        color: 0xaaaaaa,
        size: 0.7,
        map: sprite
    });
    
    stars = new tjs.Points(starGeo, starMaterial);
    scene.add(stars);
    
    animate();
}

function animate() {
    renderer.render(scene, camera);
    requestAnimationFrame(animate);
}

init();