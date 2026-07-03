/*==================================
  PRIME E-BOOKS
  SCRIPT.JS - PARTE 1
==================================*/

// ================================
// MENU MOBILE
// ================================

const menuButton = document.querySelector(".menu-mobile");
const nav = document.querySelector("nav");

if(menuButton){

    menuButton.addEventListener("click",()=>{

        nav.classList.toggle("active");

    });

}

// ================================
// ABRIR / FECHAR CHAT
// ================================

const openAssistant = document.getElementById("openAssistant");
const closeAssistant = document.getElementById("closeAssistant");
const chatWindow = document.getElementById("chatWindow");

if(openAssistant){

    openAssistant.addEventListener("click",()=>{

        chatWindow.style.display="block";

    });

}

if(closeAssistant){

    closeAssistant.addEventListener("click",()=>{

        chatWindow.style.display="none";

    });

}

// ================================
// ELEMENTOS DO CHAT
// ================================

const chatMessages = document.getElementById("chatMessages");
const userInput = document.getElementById("userInput");
const sendMessage = document.getElementById("sendMessage");

// ================================
// CRIAR MENSAGEM
// ================================

function createMessage(text,type){

    const div=document.createElement("div");

    div.className="message "+type;

    div.textContent=text;

    chatMessages.appendChild(div);

    chatMessages.scrollTop=chatMessages.scrollHeight;

}

// ================================
// MENSAGEM DO USUÁRIO
// ================================

function userMessage(){

    const text=userInput.value.trim();

    if(text==="") return;

    createMessage(text,"user");

    userInput.value="";

    setTimeout(()=>{

        botReply(text);

    },600);

}

sendMessage.addEventListener("click",userMessage);

userInput.addEventListener("keypress",(e)=>{

    if(e.key==="Enter"){

        userMessage();

    }

});/*==================================
  PRIME E-BOOKS
  SCRIPT.JS - PARTE 2
==================================*/

function botReply(question){

    const q = question.toLowerCase();

    // Saudação
    if(
        q.includes("oi") ||
        q.includes("olá") ||
        q.includes("ola") ||
        q.includes("bom dia") ||
        q.includes("boa tarde") ||
        q.includes("boa noite")
    ){

        createMessage(
            "Olá! 👋 Seja bem-vindo à Prime E-books. Como posso ajudar você?",
            "bot"
        );

    }

    // Compra
    else if(
        q.includes("comprar") ||
        q.includes("compra")
    ){

        createMessage(
            "É muito simples! Escolha um e-book, clique em 'Comprar Agora', faça o pagamento pela Kiwify e você receberá o acesso automaticamente.",
            "bot"
        );

    }

    // Acesso
    else if(
        q.includes("recebo") ||
        q.includes("acesso") ||
        q.includes("email") ||
        q.includes("e-mail")
    ){

        createMessage(
            "Após a confirmação do pagamento, a Kiwify envia automaticamente o acesso para o e-mail informado na compra.",
            "bot"
        );

    }

    // Pagamento
    else if(
        q.includes("pix") ||
        q.includes("cartão") ||
        q.includes("pagamento")
    ){

        createMessage(
            "Os pagamentos são realizados pela Kiwify. As formas disponíveis aparecem no checkout, podendo incluir Pix, cartão e outras opções.",
            "bot"
        );

    }

    // Segurança
    else if(
        q.includes("seguro") ||
        q.includes("confiável")
    ){

        createMessage(
            "Sim! Todos os pagamentos são processados pela Kiwify em ambiente seguro.",
            "bot"
        );

    }

    // IA
    else if(
        q.includes("ia") ||
        q.includes("inteligência artificial")
    ){

        createMessage(
            "Recomendo o e-book 'IA na Prática'. Ele ensina como utilizar Inteligência Artificial de forma simples.",
            "bot"
        );

    }

    // Instagram
    else if(
        q.includes("instagram")
    ){

        createMessage(
            "O e-book 'Instagram que Vende' é ideal para quem deseja crescer e vender mais usando o Instagram.",
            "bot"
        );

    }

    // Renda
    else if(
        q.includes("renda") ||
        q.includes("dinheiro")
    ){

        createMessage(
            "O e-book 'Renda Digital' mostra formas de iniciar sua renda online de maneira prática.",
            "bot"
        );

    }

    // Finanças
    else if(
        q.includes("financeiro") ||
        q.includes("finanças")
    ){

        createMessage(
            "O 'Guia do Controle Financeiro' ajuda você a organizar seu dinheiro e melhorar sua vida financeira.",
            "bot"
        );

    }

    // Negociação
    else if(
        q.includes("negociação") ||
        q.includes("negociar")
    ){

        createMessage(
            "O e-book 'Psicologia da Negociação' ensina técnicas para negociar melhor em diversas situações.",
            "bot"
        );

    }

    // Sono Infantil
    else if(
        q.includes("sono") ||
        q.includes("bebê") ||
        q.includes("bebe")
    ){

        createMessage(
            "O 'Segredo do Sono Infantil' ajuda pais a criarem uma rotina de sono saudável para seus filhos.",
            "bot"
        );

    }

    // Resposta padrão
    else{

        createMessage(
            "Desculpe, ainda não entendi sua pergunta. Tente perguntar sobre pagamento, acesso, IA, Instagram, renda, finanças, negociação ou sono infantil.",
            "bot"
        );

    }

}/*==================================
  PRIME E-BOOKS
  SCRIPT.JS - PARTE 3
==================================*/

// ================================
// BOTÃO VOLTAR AO TOPO
// ================================

const topButton = document.createElement("button");

topButton.innerHTML = '<i class="fa-solid fa-arrow-up"></i>';

topButton.className = "top-button";

document.body.appendChild(topButton);

window.addEventListener("scroll",()=>{

    if(window.scrollY > 400){

        topButton.style.display="flex";

    }else{

        topButton.style.display="none";

    }

});

topButton.addEventListener("click",()=>{

    window.scrollTo({

        top:0,

        behavior:"smooth"

    });

});

// ================================
// ANIMAÇÃO AO ROLAR A PÁGINA
// ================================

const observer = new IntersectionObserver((entries)=>{

    entries.forEach(entry=>{

        if(entry.isIntersecting){

            entry.target.classList.add("show");

        }

    });

});

document.querySelectorAll("section").forEach(section=>{

    observer.observe(section);

});/*==================================
  PRIME E-BOOKS
  SCRIPT.JS - PARTE 4
==================================*/

// ================================
// MENSAGEM DE BOAS-VINDAS
// ================================

window.addEventListener("load",()=>{

    setTimeout(()=>{

        createMessage(

            "👋 Bem-vindo à Prime E-books! Estou aqui para ajudar você a encontrar o e-book ideal.",

            "bot"

        );

    },1000);

});

// ================================
// FECHAR CHAT COM ESC
// ================================

document.addEventListener("keydown",(e)=>{

    if(e.key==="Escape"){

        chatWindow.style.display="none";

    }

});

// ================================
// ANO AUTOMÁTICO NO RODAPÉ
// ================================

const footerYear=document.getElementById("year");

if(footerYear){

    footerYear.textContent=new Date().getFullYear();

}

console.log("✅ Prime E-books carregada com sucesso!");