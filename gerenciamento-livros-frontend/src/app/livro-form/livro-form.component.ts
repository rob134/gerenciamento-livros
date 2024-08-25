import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { LivroService } from '../livro.service';
import { Livro } from '../livro.model';

@Component({
  selector: 'app-livro-form',
  templateUrl: './livro-form.component.html',
  styleUrls: ['./livro-form.component.css']
})
export class LivroFormComponent implements OnInit {
  livro: Livro = { id: 0, titulo: '', autor: '', genero: '', ano: 0 };
  isEditMode: boolean = false;

  constructor(
    private livroService: LivroService,
    private router: Router,
    private route: ActivatedRoute
  ) { }

  ngOnInit(): void {
    const id = this.route.snapshot.paramMap.get('id');
    if (id) {
      this.isEditMode = true;
      this.loadLivro(Number(id));
    }
  }

  loadLivro(id: number): void {
    this.livroService.getLivro(id).subscribe(
      (data: Livro) => this.livro = data,
      error => console.error('Erro ao carregar livro', error)
    );
  }

  saveLivro(): void {
    if (this.isEditMode) {
      this.livroService.updateLivro(this.livro.id, this.livro).subscribe(
        () => this.router.navigate(['/livros']),
        error => console.error('Erro ao atualizar livro', error)
      );
    } else {
      this.livroService.addLivro(this.livro).subscribe(
        () => this.router.navigate(['/livros']),
        error => console.error('Erro ao adicionar livro', error)
      );
    }
  }
}
