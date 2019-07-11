import { Component } from "@angular/core";

@Component({
  selector: "app-produto",
  templateUrl: "produto.component.html"
})
export class ProdutoComponent { // Nome das classes começcando em PascalCase
  /* camelCase para variáveis, atributos e funções */
  public nome: string;
  public liberadoParaVenda: boolean;

  public obterNome(): string {
    return this.nome;
  }
}
