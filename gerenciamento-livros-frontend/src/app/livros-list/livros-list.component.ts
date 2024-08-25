import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LivroService } from '../livro.service';
import { Livro } from '../livro.model';

@Component({
  selector: 'app-livros-list',
  templateUrl: './livros-list.component.html',
  styleUrls: ['./livros-list.component.css']
})
export class LivrosListComponent implements OnInit {
  livros: Livro[] = [];

  constructor(private livroService: LivroService, private router: Router) { }

  ngOnInit(): void {
    this.loadLivros();
  }

  loadLivros(): void {
    this.livroService.getLivros().subscribe(
      (data: Livro[]) => this.livros = data,
      error => console.error('Erro ao carregar livros', error)
    );
  }

  editLivro(id: number): void {
    this.router.navigate([`/livros/editar/${id}`]);
  }

  deleteLivro(id: number): void {
    if (confirm('Você tem certeza que deseja excluir este livro?')) {
      this.livroService.deleteLivro(id).subscribe(
        () => this.loadLivros(),
        error => console.error('Erro ao excluir livro', error)
      );
    }
  }
}
