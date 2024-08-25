import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'; // Certifique-se de que está importando de '@angular/common/http'
import { Observable } from 'rxjs';
import { Livro } from './livro.model';

@Injectable({
  providedIn: 'root'
})
export class LivroService {
  private apiUrl = 'http://localhost:5098/api/livros'; // URL da API

  constructor(private http: HttpClient) { }

  getLivros(): Observable<Livro[]> {
    return this.http.get<Livro[]>(this.apiUrl);
  }

  getLivro(id: number): Observable<Livro> {
    return this.http.get<Livro>(`${this.apiUrl}/${id}`);
  }

  addLivro(livro: Livro): Observable<Livro> {
    return this.http.post<Livro>(this.apiUrl, livro);
  }

  updateLivro(id: number, livro: Livro): Observable<Livro> {
    return this.http.put<Livro>(`${this.apiUrl}/${id}`, livro);
  }

  deleteLivro(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}
