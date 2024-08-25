import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LivrosListComponent } from './livros-list/livros-list.component';
import { LivroFormComponent } from './livro-form/livro-form.component';

const routes: Routes = [
  { path: 'livros', component: LivrosListComponent },
  { path: 'livros/novo', component: LivroFormComponent },
  { path: 'livros/editar/:id', component: LivroFormComponent },
  { path: '', redirectTo: '/livros', pathMatch: 'full' },
  { path: '**', redirectTo: '/livros' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
