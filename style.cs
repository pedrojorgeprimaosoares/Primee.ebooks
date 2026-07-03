/*============================*/
/* PRIME E-BOOKS */
/* STYLE.CSS - PARTE 1 */
/*============================*/

*{
margin:0;
padding:0;
box-sizing:border-box;
scroll-behavior:smooth;
}

:root{

--primary:#2563eb;
--primary-dark:#1d4ed8;
--background:#050816;
--background2:#0f172a;
--card:#111827;
--border:#1f2937;
--white:#ffffff;
--text:#d1d5db;
--success:#22c55e;
--radius:18px;
--shadow:0 15px 35px rgba(0,0,0,.35);

}

body{

font-family:'Poppins',sans-serif;
background:linear-gradient(180deg,#050816,#0f172a);
color:var(--white);
overflow-x:hidden;
line-height:1.6;

}

.container{

width:min(1200px,92%);
margin:auto;

}

img{

max-width:100%;
display:block;

}

a{

text-decoration:none;
color:inherit;

}

section{

padding:90px 0;

}

/*============================*/
/* HEADER */
/*============================*/

header{

position:sticky;
top:0;
z-index:999;
background:rgba(5,8,22,.92);
backdrop-filter:blur(14px);
border-bottom:1px solid rgba(255,255,255,.06);

}

header .container{

display:flex;
justify-content:space-between;
align-items:center;
height:80px;

}

.logo{

display:flex;
align-items:center;
gap:12px;
font-size:28px;
font-weight:700;
color:var(--white);

}

.logo i{

color:var(--primary);

}

nav{

display:flex;
gap:35px;

}

nav a{

font-weight:500;
transition:.3s;

}

nav a:hover{

color:var(--primary);

}

.menu-mobile{

display:none;
background:none;
border:none;
color:white;
font-size:26px;
cursor:pointer;

}

/*============================*/
/* HERO */
/*============================*/

.hero{

padding:100px 0;

}

.hero-content{

display:grid;
grid-template-columns:1fr 1fr;
gap:70px;
align-items:center;

}

.badge{

display:inline-block;
padding:8px 18px;
background:rgba(37,99,235,.15);
color:#8bb6ff;
border-radius:50px;
font-size:14px;
margin-bottom:20px;

}

.hero h1{

font-size:58px;
line-height:1.15;
margin-bottom:20px;

}

.hero p{

font-size:19px;
color:var(--text);
margin-bottom:35px;

}

.hero-buttons{

display:flex;
gap:20px;
margin-bottom:40px;

}

.btn-primary{

background:var(--primary);
padding:16px 34px;
border-radius:12px;
font-weight:600;
transition:.3s;

}

.btn-primary:hover{

background:var(--primary-dark);
transform:translateY(-4px);

}

.btn-secondary{

border:2px solid var(--primary);
padding:16px 34px;
border-radius:12px;
font-weight:600;
transition:.3s;

}

.btn-secondary:hover{

background:var(--primary);

}

.hero-info{

display:flex;
gap:30px;
flex-wrap:wrap;

}

.hero-info div{

display:flex;
align-items:center;
gap:10px;
color:var(--text);

}

.hero-info i{

color:var(--success);

}

.hero-image img{

animation:float 4s ease-in-out infinite;

}

@keyframes float{

0%{

transform:translateY(0);

}

50%{

transform:translateY(-15px);

}

100%{

transform:translateY(0);

}

}/*============================*/
/* TÍTULOS DAS SEÇÕES */
/*============================*/

.section-header{

text-align:center;
margin-bottom:60px;

}

.section-tag{

display:inline-block;
padding:8px 18px;
background:rgba(37,99,235,.15);
color:#8bb6ff;
border-radius:40px;
font-size:14px;
font-weight:600;
margin-bottom:18px;

}

.section-header h2{

font-size:42px;
margin-bottom:15px;

}

.section-header p{

max-width:700px;
margin:auto;
color:var(--text);
font-size:18px;

}

/*============================*/
/* E-BOOKS */
/*============================*/

.books-grid{

display:grid;
grid-template-columns:repeat(auto-fit,minmax(300px,1fr));
gap:35px;

}

.book-card{

background:var(--card);
border:1px solid var(--border);
border-radius:var(--radius);
overflow:hidden;
transition:.35s;
box-shadow:var(--shadow);

}

.book-card:hover{

transform:translateY(-10px);
border-color:var(--primary);

}

.book-card img{

width:100%;
height:420px;
object-fit:cover;
transition:.4s;

}

.book-card:hover img{

transform:scale(1.05);

}

.book-info{

padding:24px;

}

.category{

display:inline-block;
padding:7px 14px;
background:rgba(37,99,235,.15);
color:#8bb6ff;
border-radius:30px;
font-size:13px;
margin-bottom:18px;

}

.book-info h3{

font-size:24px;
margin-bottom:15px;

}

.book-info p{

color:var(--text);
margin-bottom:25px;
line-height:1.7;

}

.buy-button{

display:block;
text-align:center;
padding:15px;
background:var(--primary);
color:white;
font-weight:600;
border-radius:12px;
transition:.3s;

}

.buy-button:hover{

background:var(--primary-dark);
transform:translateY(-3px);

}

/*============================*/
/* PRODUTOS EM DESTAQUE */
/*============================*/

.featured-books{

background:#08111f;

}

.all-books{

background:transparent;

}/*============================*/
/* BENEFÍCIOS */
/*============================*/

.benefits{

background:#08111f;

}

.benefits-grid{

display:grid;
grid-template-columns:repeat(auto-fit,minmax(250px,1fr));
gap:30px;

}

.benefit-card{

background:var(--card);
padding:35px 25px;
border-radius:var(--radius);
border:1px solid var(--border);
text-align:center;
transition:.35s;
box-shadow:var(--shadow);

}

.benefit-card:hover{

transform:translateY(-10px);
border-color:var(--primary);

}

.benefit-icon{

width:80px;
height:80px;
margin:0 auto 25px;
display:flex;
justify-content:center;
align-items:center;
border-radius:50%;
background:rgba(37,99,235,.15);
font-size:34px;
color:var(--primary);

}

.benefit-card h3{

margin-bottom:15px;
font-size:22px;

}

.benefit-card p{

color:var(--text);
line-height:1.7;

}

/*============================*/
/* ESTATÍSTICAS */
/*============================*/

.stats{

padding:80px 0;

}

.stats-grid{

display:grid;
grid-template-columns:repeat(auto-fit,minmax(220px,1fr));
gap:25px;

}

.stat-card{

background:var(--card);
padding:35px;
border-radius:var(--radius);
border:1px solid var(--border);
text-align:center;
transition:.35s;

}

.stat-card:hover{

transform:translateY(-8px);

}

.stat-card h2{

font-size:48px;
color:var(--primary);
margin-bottom:10px;

}

.stat-card p{

color:var(--text);

}

/*============================*/
/* PRIME ASSISTENTE */
/*============================*/

.assistant-section{

background:#08111f;

}

.assistant-box{

display:grid;
grid-template-columns:320px 1fr;
gap:50px;
align-items:center;

}

.robot-circle{

width:220px;
height:220px;
margin:auto;
border-radius:50%;
display:flex;
justify-content:center;
align-items:center;
background:linear-gradient(135deg,#2563eb,#1d4ed8);
box-shadow:0 0 40px rgba(37,99,235,.35);

}

.robot-circle i{

font-size:90px;
color:white;

}

.assistant-content h2{

font-size:42px;
margin:20px 0;

}

.assistant-content p{

color:var(--text);
margin-bottom:25px;
line-height:1.8;

}

.assistant-list{

list-style:none;
margin-bottom:35px;

}

.assistant-list li{

display:flex;
align-items:center;
gap:12px;
margin-bottom:18px;
color:var(--text);

}

.assistant-list i{

color:var(--success);

}

/*============================*/
/* CHAT */
/*============================*/

.chat-window{

position:fixed;
right:30px;
bottom:30px;
width:380px;
max-width:95%;
background:var(--card);
border-radius:20px;
overflow:hidden;
display:none;
border:1px solid var(--border);
box-shadow:0 20px 45px rgba(0,0,0,.4);
z-index:9999;

}

.chat-header{

background:var(--primary);
padding:18px;
display:flex;
justify-content:space-between;
align-items:center;

}

.chat-user{

display:flex;
align-items:center;
gap:12px;

}

.chat-avatar{

width:55px;
height:55px;
background:white;
color:var(--primary);
display:flex;
justify-content:center;
align-items:center;
border-radius:50%;
font-size:26px;

}

.chat-header h3{

font-size:18px;

}

.chat-header p{

font-size:13px;
opacity:.9;

}

#closeAssistant{

background:none;
border:none;
color:white;
font-size:24px;
cursor:pointer;

}

.chat-messages{

height:320px;
overflow-y:auto;
padding:20px;

}

.message{

padding:14px 18px;
border-radius:14px;
margin-bottom:15px;
line-height:1.7;

}

.message.bot{

background:#1f2937;

}

.message.user{

background:var(--primary);
margin-left:40px;

}

.chat-input{

display:flex;
gap:10px;
padding:18px;
border-top:1px solid var(--border);

}

.chat-input input{

flex:1;
padding:14px;
border:none;
outline:none;
border-radius:10px;
background:#0f172a;
color:white;

}

.chat-input button{

width:55px;
border:none;
border-radius:10px;
background:var(--primary);
color:white;
font-size:20px;
cursor:pointer;

}/*============================*/
/* AVALIAÇÕES */
/*============================*/

.testimonials{

background:var(--background);

}

.testimonials-grid{

display:grid;
grid-template-columns:repeat(auto-fit,minmax(300px,1fr));
gap:30px;

}

.testimonial-card{

background:var(--card);
padding:30px;
border-radius:var(--radius);
border:1px solid var(--border);
box-shadow:var(--shadow);
transition:.3s;

}

.testimonial-card:hover{

transform:translateY(-8px);
border-color:var(--primary);

}

.stars{

font-size:22px;
color:#facc15;
margin-bottom:20px;

}

.testimonial-card p{

color:var(--text);
line-height:1.8;
margin-bottom:20px;

}

.testimonial-card h4{

font-size:20px;
margin-bottom:5px;

}

.testimonial-card span{

color:var(--text);
font-size:14px;

}

/*============================*/
/* CONTATO */
/*============================*/

.contact{

background:#08111f;

}

.contact-box{

display:grid;
grid-template-columns:repeat(auto-fit,minmax(250px,1fr));
gap:30px;

}

.contact-item{

background:var(--card);
padding:35px;
text-align:center;
border-radius:var(--radius);
border:1px solid var(--border);
transition:.3s;

}

.contact-item:hover{

transform:translateY(-8px);
border-color:var(--primary);

}

.contact-item i{

font-size:42px;
color:var(--primary);
margin-bottom:20px;

}

.contact-item h3{

margin-bottom:10px;

}

.contact-item p{

color:var(--text);

}

/*============================*/
/* FOOTER */
/*============================*/

footer{

background:#030712;
padding:70px 0 30px;
border-top:1px solid var(--border);

}

.footer-container{

display:flex;
flex-direction:column;
align-items:center;
text-align:center;
gap:30px;

}

.footer-brand h2{

font-size:34px;

}

.footer-brand span{

color:var(--primary);

}

.footer-brand p{

margin-top:10px;
color:var(--text);

}

.footer-links{

display:flex;
gap:30px;
flex-wrap:wrap;

}

.footer-links a{

transition:.3s;

}

.footer-links a:hover{

color:var(--primary);

}

.footer-copy{

color:var(--text);
font-size:15px;

}

/*============================*/
/* RESPONSIVO */
/*============================*/

@media(max-width:900px){

.hero-content,
.assistant-box{

grid-template-columns:1fr;
text-align:center;

}

.hero-buttons{

justify-content:center;

}

.hero-info{

justify-content:center;

}

nav{

display:none;

}

.menu-mobile{

display:block;

}

}

@media(max-width:768px){

.hero h1{

font-size:38px;

}

.section-header h2{

font-size:30px;

}

.hero-buttons{

flex-direction:column;

}

.btn-primary,
.btn-secondary{

display:block;
text-align:center;

}

.chat-window{

width:95%;
right:2.5%;
bottom:15px;

}

}

@media(max-width:480px){

section{

padding:70px 0;

}

.logo{

font-size:22px;

}

.book-card img{

height:320px;

}

.robot-circle{

width:170px;
height:170px;

}

.robot-circle i{

font-size:70px;

}

}

/*============================*/
/* SCROLLBAR */
/*============================*/

::-webkit-scrollbar{

width:10px;

}

::-webkit-scrollbar-thumb{

background:var(--primary);
border-radius:20px;

}

::-webkit-scrollbar-track{

background:var(--background);

}
