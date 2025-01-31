import { Component, OnInit } from '@angular/core';
import { ProductService, Product } from '../app/services/product.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule],
  template: `
    <h1>Gestión de Inventario</h1>
    <ul>
      <li *ngFor="let product of products">
        {{ product.name }} (Stock: {{ product.stock }})
      </li>
    </ul>
  `,
})
export class AppComponent implements OnInit {
  products: Product[] = [];

  constructor(private productService: ProductService) {}

  ngOnInit() {
    this.productService.getProducts().subscribe({
      next: (data: Product[]) => {
        this.products = data;
      },
      error: (err: any) => console.error('Error al cargar productos:', err),
    });
  }
}
